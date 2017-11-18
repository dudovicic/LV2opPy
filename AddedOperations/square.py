import clr
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import *
clr.AddReference ("System.Drawing")
from System.Drawing import Size
import math

#racunanje kvadrata
def sqFun(sender,e):
    frm = sender.Tag
    x1 = frm.tbX1.Text
    res = math.pow(float(x1),2)
    frm.tbResult.Text = str(res)


def Dodaj(frm):
    newOp = ToolStripMenuItem(Text='Square',Name='pow',Size=Size(104, 20))
    newOp.Tag = frm
    newOp.Click += sqFun
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(newOp)
