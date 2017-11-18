import clr
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import *
clr.AddReference ("System.Drawing")
from System.Drawing import Size
import math

#racunanje korijena
def sqRootFun(sender,e):
    frm = sender.Tag
    x1 = frm.tbX1.Text
    res = math.sqrt(float(x1))
    frm.tbResult.Text = str(res)

def Dodaj(frm):
    newOp = ToolStripMenuItem(Text='SqRoot', Name='sqrt', Size=Size(104, 20))
    newOp.Tag = frm
    newOp.Click += sqRootFun
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(newOp)
