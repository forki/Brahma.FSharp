﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE
{
	public partial class Watch : Form
	{
		public Watch(Form parent = null)
		{
			InitializeComponent();
			MdiParent = parent;
		}
	}
}
