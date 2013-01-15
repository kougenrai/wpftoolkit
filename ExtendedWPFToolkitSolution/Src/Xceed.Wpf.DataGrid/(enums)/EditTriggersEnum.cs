﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   For more features, controls, and fast professional support,
   pick up the Plus edition at http://xceed.com/wpf_toolkit

   Visit http://xceed.com and follow @datagrid on Twitter

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Xceed.Wpf.DataGrid
{
  [Flags]
  public enum EditTriggers
  {
    None = 0x00,
    BeginEditCommand = 0x01,
    ClickOnCurrentCell = 0x02,
    SingleClick = 0x04,
    CellIsCurrent = 0x08,
    ActivationGesture = 0x10,
    RowIsCurrent = 0x20,
  }
}