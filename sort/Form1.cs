using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace VsualSorfWF
{
	public partial class Sort : Form 
	{
		public int[] array;

		public Sort()
		{
			InitializeComponent();
		}

		private void SortVibor_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now;
			Random random = new Random();
			array = new int[(int)countElements.Value];
			array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				int min = i;
				for (int j = i + 1; j < array.Length; j++)
					if (array[j] < array[min])
						min = j;

				if (min != i)
					swap(ref array[i], ref array[min]);

				drawSort(array);
				//drawMarking();
				Thread.Sleep(100);
			}
			DateTime end = DateTime.Now;
			TimeSpan ts = (end - start);
			LabelTime.Text = Convert.ToString(ts.Milliseconds);
		}
		private void ShakerSort_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now;
			Random random = new Random();
			array = new int[(int)countElements.Value];
			array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();
			for (var i = 0; i < array.Length / 2; i++)
			{
				var swapFlag = false;
				//проход слева направо
				for (var j = i; j < array.Length - i - 1; j++)
				{
					if (array[j] > array[j + 1])
					{
						Swap(ref array[j], ref array[j + 1]);
						swapFlag = true;
					}
				}

				//проход справа налево
				for (var j = array.Length - 2 - i; j > i; j--)
				{
					if (array[j - 1] > array[j])
					{
						Swap(ref array[j - 1], ref array[j]);
						swapFlag = true;
					}
				}

				//если обменов не было выходим
				if (!swapFlag)
					break;
				drawSort(array);
				//drawMarking();
				Thread.Sleep(1000);
			}
			DateTime end = DateTime.Now;
			TimeSpan ts = (end - start);
			LabelTime.Text = Convert.ToString(ts.Milliseconds);
		}
		private void InsertionSort_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now;
			Random random = new Random();
			array = new int[(int)countElements.Value];
			array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();
			for (int i = 1; i < array.Length; i++)
			{
				int cur = array[i];
				int j = i;
				while (j > 0 && cur < array[j - 1])
				{
					array[j] = array[j - 1];
					j--;
				}
				array[j] = cur;
			
				drawSort(array);
				//drawMarking();
				Thread.Sleep(100);
			}
			DateTime end = DateTime.Now;
			TimeSpan ts = (end - start);
			LabelTime.Text = Convert.ToString(ts.Milliseconds);

		}
		private void ShellSort_Click(object sender, EventArgs e)
		{
			DateTime start = DateTime.Now;
			Random random = new Random();
			array = new int[(int)countElements.Value];
			array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();
			var step = array.Length / 2; // шаг
			while (step >= 1)
			{
				for (var i = step; i < array.Length; i++)
				{
					var j = i;
					while ((j >= step) && (array[j - step] > array[j]))
					{
						Swap(ref array[j], ref array[j - step]);
						j = j - step;
					}
				}

				step = step / 2;
				drawSort(array);
				//drawMarking();
				Thread.Sleep(100);

			}
			DateTime end = DateTime.Now;
			TimeSpan ts = (end - start);
			LabelTime.Text = Convert.ToString(ts.Milliseconds);
		}


		private void swap<T>(ref T a, ref T b)
		{
			T c = a;
			a = b;
			b = c;
		}
		static void Swap(ref int e1, ref int e2)
		{
			var temp = e1;
			e1 = e2;
			e2 = temp;
		}


		private void drawSort(int[] array)
		{
			bool flag = true;
			Pen pen = new Pen(Color.DarkViolet);


			Graphics graphics = pictureBox1.CreateGraphics();
			graphics.Clear(Color.DarkGray);
			for (int i = (int)minLim.Value; i <= maxLim.Value; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (flag)
						pen = new Pen(Color.DarkKhaki);
					else
						pen = new Pen(Color.LightYellow);
					flag = !flag;

					if (array[j] >= i)
						graphics.FillRectangle(new SolidBrush(pen.Color), 10 * j, pictureBox1.Height - 10 * i, 10, 10);
				}
			}
		}

        //private void drawMarking()
        //{
        //    Graphics graphics = pictureBox1.CreateGraphics();

        //    Pen pen = new Pen(Color.Black);
        //    for (int i = 0; i < pictureBox1.Height; i += 8)
        //        graphics.DrawLine(pen, 0, pictureBox1.Height - i, pictureBox1.Width, pictureBox1.Height - i);
        //    for (int i = 0; i < pictureBox1.Width; i += 8)
        //        graphics.DrawLine(pen, i, 0, i, pictureBox1.Width);
        //}

  //      private void pictureBox1_Paint(object sender, PaintEventArgs e)
		//{
		//	((PictureBox)sender).CreateGraphics().Clear(Color.Black);
		//	drawMarking();
		//}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

        private void GnomeSort_Click(object sender, EventArgs e)
        {
			DateTime start = DateTime.Now;
			Random random = new Random();
				array = new int[(int)countElements.Value];
			array = array.Select(x => random.Next((int)minLim.Value, (int)(maxLim.Value + 1))).ToArray();
			var index = 1;
				var nextIndex = index + 1;

				while (index < array.Length)
				{
					if (array[index - 1] < array[index])
					{
						index = nextIndex;
						nextIndex++;
					}
					else
					{
						Swap(ref array[index - 1], ref array[index]);
						index--;
						if (index == 0)
						{
							index = nextIndex;
							nextIndex++;
						}
					}
				drawSort(array);
				//drawMarking();
				Thread.Sleep(100);
			}
			DateTime end = DateTime.Now;
			TimeSpan ts = (end - start);
			LabelTime.Text = Convert.ToString(ts.Milliseconds);
		}

        private void minLim_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
    }



