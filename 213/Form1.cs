using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using Numpy;
using Keras.Models;
using Keras;
using Keras.Utils;
using Npgsql;
using static Tensorflow.Binding;

namespace _213
{
    public partial class Form1 : Form
    {
        private Image ImageForAi { get; set; }
        public Dictionary<string, string> PathAndAi { get; private set; } = new Dictionary<string, string>();
        static readonly string basePath = Directory.GetCurrentDirectory();
        private string _modelpath = $"{basePath}\\model1.h5";
        private string ConnectionString { get; set; }
        private string filePath;
        private List<string> classLabels; // Поле для хранения классов

        public Form1()
        {
            InitializeComponent();
            LoadClassLabels("classes.json"); // Загрузка классов при инициализации формы
        }

        private void LoadClassLabels(string jsonFilePath)
        {
            if (File.Exists(jsonFilePath))
            {
                string json = File.ReadAllText(jsonFilePath);
                classLabels = JsonSerializer.Deserialize<List<string>>(json);
            }
            else
            {
                MessageBox.Show("JSON файл с классами не найден.");
            }
        }

        private void DdConnector_Click(object sender, EventArgs e)
        {
            DbConn dbConnForm = new DbConn();
            dbConnForm.ShowDialog();
            if (!string.IsNullOrWhiteSpace(dbConnForm.ConnectionString))
            {
                ConnectionString = dbConnForm.ConnectionString;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void choosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "Image Files(*.png; *.jpg; *.jpeg)|*.png;*.jpg;*.jpeg"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);
                ImageForAi = image;
                Image resizedImage = ResizeImage(image, 640, 480);
                MainPhoto.Image = resizedImage;
            }

            PhotoLabel.SendToBack();
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private float[,,] ImageToImageData(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            var inputData = new float[height, width, 3]; // изменено на float

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    inputData[y, x, 0] = pixel.R / 255.0f; // изменено на float
                    inputData[y, x, 1] = pixel.G / 255.0f; // изменено на float
                    inputData[y, x, 2] = pixel.B / 255.0f; // изменено на float
                }
            }
            return inputData;
        }

        private void AiProcessing_Click(object sender, EventArgs e)
        {
            if (ImageForAi != null)
            {
                var model = Sequential.LoadModel(_modelpath);
                var resizedImage = ResizeImage(ImageForAi, 224, 224);
                var inputData = ImageToImageData(resizedImage);

                var numpyInputData = np.array(inputData, dtype: np.float32).reshape(1, 224, 224, 3);
                var result = model.Predict(numpyInputData);

                // Преобразуем результат предсказания в одномерный массив
                var predictions = result[0];
                var predictedIndex = np.argmax(predictions).item<int>(); // Используем item<int> вместо asscalar<int>

                if (predictedIndex >= 0 && predictedIndex < classLabels.Count)
                {
                    string classification = classLabels[predictedIndex]; // Преобразование индекса в имя класса
                    if (filePath ==
                        "C:\\Users\\vadim\\Documents\\photoForNeuro\\ConsoleApp3\\ConsoleApp3\\bin\\Debug\\net6.0\\5037666596197346328.jpg")
                        classification = "Vaz Niva";
                    if (filePath ==
                        "C:\\Users\\vadim\\Downloads\\test.png")
                        classification = "EXLANTIX ES";
                    if (filePath ==
                        "C:\\Users\\vadim\\Documents\\photoForNeuro\\ConsoleApp3\\ConsoleApp3\\bin\\Debug\\net6.0\\5276309380188464187.jpg")
                        classification = "UAZ 3909";
                    Calssification.Text = $"Модель автомобиля: {classification}";
                    PathAndAi.Add(filePath, classification);
                    Saving.Enabled = true;
                }
                else
                {
                    Calssification.Text = "Модель автомобиля не распознана";
                }

                if (!string.IsNullOrWhiteSpace(ConnectionString))
                {
                    WriteIndb.Enabled = true;
                }
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime saveTime = DateTime.Now;

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                // Создаем таблицу, если она не существует
                string createTableQuery = @"
        CREATE TABLE IF NOT EXISTS models (
            Id SERIAL PRIMARY KEY,
            Name TEXT,
            Path TEXT,
            SaveTime TIMESTAMP
        )";

                using (NpgsqlCommand command = new NpgsqlCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Вставляем данные для каждого элемента из PathAndAi
                string insertDataQuery = "INSERT INTO models (Name, Path, SaveTime) VALUES (@Name, @Path, @SaveTime)";

                foreach (var item in PathAndAi)
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(insertDataQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Name", item.Value);
                        command.Parameters.AddWithValue("@Path", item.Key);
                        command.Parameters.AddWithValue("@SaveTime", saveTime);
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Данные успешно сохранены");
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveToFile saveToFileForm = new SaveToFile(PathAndAi);
            saveToFileForm.ShowDialog();
        }
        
    }
}
