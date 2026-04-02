using System.Windows.Forms;

namespace easterEpp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Form form = new Form();
            form.Text = "My Window";

            // Create the button
            Button button = new Button();
            button.Text = "Click me!";
            button.Width = 100;
            button.Height = 40;
            button.Top = 20;
            button.Left = 20;

            // Add click event
            button.Click += (sender, e) =>
            {
                MessageBox.Show("Button clicked!");
            };

            // Add button to form
            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}