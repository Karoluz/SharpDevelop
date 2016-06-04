/*
 * Created by SharpDevelop.
 * User: Karloz
 * Date: 24/01/2016
 * Time: 09:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace SerialPort
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			//configurin the serial port COM8
			serialPort1.PortName="COM8";
			serialPort1.BaudRate="9600";
			serialPort1.DataBits="8";
			serialPort1.Parity=Parity.None;
			serialPort1.StopBits=StopBits.One;
			//opening the serial port
			serialPort1.Open();
		}
	}
}