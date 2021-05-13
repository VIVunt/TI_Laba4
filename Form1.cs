using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Laba4
{
    public partial class Form1 : Form
    {
        private FLSR29 FLSR = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void EncipherFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = this.openFileDialog1.FileName;
                byte[] bytes = File.ReadAllBytes(filename);
                if (this.SecretKey.Text == "")
                {
                    MessageBox.Show("Не введён секретный ключ");
                    return;
                }
                FLSR = new FLSR29(Int32.Parse(this.SecretKey.Text), bytes.Length);
                bytes = FLSR.Encipher(bytes);
                File.WriteAllBytes(filename, bytes);
                MessageBox.Show("Файл был зашифрован");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void DecipherFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = this.openFileDialog1.FileName;
                byte[] bytes = File.ReadAllBytes(filename);
                bytes = FLSR.Encipher(bytes);
                File.WriteAllBytes(filename, bytes);
                MessageBox.Show("Файл был расшифрован");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }

    public class FLSR29 : Object
    {
        public byte[] Key;

        public FLSR29(int key, int n)
        {
            //Проверка правильного диапазона числа
            if ((key == 0) ||
                (key > (int)(Math.Pow(2, 29) - 1)) ||
                (n * 8 > (int)(Math.Pow(2, 29) - 1))) 
            {
                MessageBox.Show("Error number");
                return;
            }

            Key = new byte[n];

            //Формирование M последовательности
            BitArray Keybits = new BitArray(n * 8);
            Keybits.SetAll(false);

            byte[] bytes = BitConverter.GetBytes(key);

            BitArray bits = new BitArray(bytes);
            bits.Length = 29;
            BitArray tempbits = new BitArray(bits);

            for (int i = 0; i < Keybits.Count; i++)
            {
                Keybits[i] = bits[0];

                //Логический сдвиг
                for (int m = bits.Length - 1; m > 0; m--)
                {
                    bits[m] = bits[m - 1];

                }
                bits[0] = tempbits[1] ^ tempbits[28];

                tempbits = new BitArray(bits);
            }

            Keybits.CopyTo(Key, 0);
        }

        public byte[] Encipher(byte[] bytes)
        {
            byte[] resbytes = new byte[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                resbytes[i] = (byte)(bytes[i] ^ Key[i]);     
            }

            return resbytes;
        }

    }
}
