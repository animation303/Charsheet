using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charsheet
{
	public partial class intTextBox : TextBox
	{
		int value = 0;
		//Access the "Value" property to get the number as an int value. 
		public int Value
		{
			get
			{
				return value;
			}
		}

		public intTextBox()
		{
			//Set the text to a default number value of 0 
			Text = "0";

			//Add a listener to the "TextChanged" event so that we can affect what happens whenever the text is changed. 
			TextChanged += intTextBox_TextChanged;
		}

		private void intTextBox_TextChanged(object sender, EventArgs e)
		{
			int temp;
			//Check if the new text is a valid int number. 
			if (int.TryParse(Text, out temp))
			{
				//If the new text is a valid int value, 
				//set the stored value to that new value. 
				value = temp;
			}
			else
			{
				//If the new text isn't a valid int value, 
				//set the text back to what it previously was. 
				Text = value.ToString();
			}
		}
	}
}
