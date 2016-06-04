/*
 * Created by SharpDevelop.
 * User: Karloz
 * Date: 24/01/2016
 * Time: 09:55 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SerialPort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//configurin the serial port COM8
			serialPort1.PortName="COM8";
			serialPort1.BaudRate=9600;
			serialPort1.DataBits=8;
			//serialPort1.Parity=Parity.None;
			//serialPort1.StopBits=StopBits.One;
			//opening the serial port
			serialPort1.Open();
		}
		void Button2Click(object sender, EventArgs e)
		{
			serialPort1.Write("p");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			serialPort1.Write("a");
		}
						
		void Button5Click(object sender, EventArgs e)
		{
			serialPort1.Write("r");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			//close the port
			serialPort1.Write("s");
			serialPort1.Close();
		}
	}
}
