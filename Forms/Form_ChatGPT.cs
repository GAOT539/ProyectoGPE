//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
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ProyectoSGBD_MySQL.Forms
{
    public partial class Form_ChatGPT : Form
    {
        private const string apiKey = "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";
        private const string endpoint = "https://api.openai.com/v1/engines/davinci-codex/completions";

        public Form_ChatGPT()
        {
            InitializeComponent();
        }

        private async void button_Enviar_Click(object sender, EventArgs e)
        {
            string pregunta = textBox_Pregunta.Text;

            if (!string.IsNullOrWhiteSpace(pregunta))
            {
                try
                {
                    // Configura la solicitud
                    var requestData = new
                    {
                        prompt = pregunta,
                        max_tokens = 50
                    };
                    var requestBody = JsonConvert.SerializeObject(requestData);

                    using (var client = new HttpClient())
                    {
                        // Configura el encabezado de autorización
                        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
                        // Configura el encabezado de contenido
                        client.DefaultRequestHeaders.Add("Content-Type", "application/json");

                        // Envía la solicitud POST a la API
                        var response = await client.PostAsync(endpoint, new StringContent(requestBody, Encoding.UTF8, "application/json"));

                        // Lee la respuesta
                        var responseContent = await response.Content.ReadAsStringAsync();

                        // Deserializa la respuesta JSON
                        dynamic responseObject = JsonConvert.DeserializeObject(responseContent);

                        // Obtiene la respuesta generada por el modelo
                        string respuesta = responseObject.choices[0].text;

                        // Muestra la respuesta en el ListBox
                        listBox_Respuesta.Items.Add(respuesta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al enviar la pregunta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una pregunta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
