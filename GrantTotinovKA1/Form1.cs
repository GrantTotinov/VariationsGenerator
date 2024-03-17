using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GrantTotinovKA1
{
    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();

            combobox.Items.Add("Целочислен");
            combobox.Items.Add("Символен");
            combobox.SelectedIndex = 0;
        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int n, k;

                if (!int.TryParse(elementtxtbox.Text, out n))
                {
                    MessageBox.Show("Моля въведете число за броя на елементите", "Error");
                    return;
                }
                if (!int.TryParse(classtxtbox.Text, out k))
                {
                    MessageBox.Show("Моля въведете число за номер на класа", "Error");
                    return;
                }
                if (n <= 0)
                {
                    MessageBox.Show("Моля въведете валидно числo за броя на елементите", "Error");
                    return;
                }
                if (k <= 0 || k > n || k == n)
                {
                    MessageBox.Show("Моля въведете валидно числo за класа", "Error");
                    return;
                }
                List<string> variations;
                if (combobox.SelectedIndex == 0) // izbrano int
                {
                    variations = GenerateVariations(n, k, Enumerable.Range(1, n).Select(x => x.ToString()));
                }
                else // izbranoo char
                {
                    char startChar = 'A';
                    variations = GenerateVariations(n, k, Enumerable.Range(0, n).Select(x => ((char)(startChar + x)).ToString()));
                }

                resulttxtbox.Text = string.Join(Environment.NewLine, variations);
                countlabel.Text = $"Броят на вариациите без повторение са: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при процеса: {ex.Message}", "Error");
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About about = new();
            about.ShowDialog();
        }

        private List<string> GenerateVariations<T>(int n, int k, IEnumerable<T> elements)
        {
            List<string> result = new();
            
            count = 0;

            List<List<T>> variations = GenerateVariationsRecursive(new List<T>(elements), k);

            foreach (List<T> variation in variations)
            {
                result.Add(string.Join(", ", variation));
                count++;
            }

            return result;
        }

        private List<List<T>> GenerateVariationsRecursive<T>(List<T> elements, int k)
        {
            List<List<T>> result = new();
            

            try
            {
                if (k == 1)
                {
                    foreach (T element in elements)
                    {
                        result.Add(new List<T> { element });
                    }
                }
                else
                {
                    foreach (T element in elements)
                    {
                        List<T> remainingElements = new List<T>(elements);
                        remainingElements.Remove(element);

                        List<List<T>> subVariations = GenerateVariationsRecursive(remainingElements, k - 1);

                        foreach (List<T> subVariation in subVariations)
                        {
                            List<T> variation = new List<T> { element };
                            variation.AddRange(subVariation);
                            result.Add(variation);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Грешка при генерирането на вариациите: {ex.Message}", "Error");
            }

            return result;
        }
    }
}
