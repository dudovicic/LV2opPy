import clr
clr.AddReference("System.Windows.Forms")
from System.Windows.Forms import *
clr.AddReference ("System.Drawing")
from System.Drawing import Size
import math

#racunanje sinusa u rad i stupnjevima
def sinFun(sender,e):
    frm = sender.Tag
    x1 = frm.tbX1.Text
    res = math.sin(float(x1))
    frm.tbResult.Text=str(res)
    frm.label3.Text='Radians'
    frm.X2.Text='Degrees'
    resD = math.sin(math.radians(float(x1)))
    frm.tbX2.Text=str(resD)

def Dodaj(frm):
    newOp = ToolStripMenuItem(Text='Sinus',Name='sin',Size=Size(104, 20))
    newOp.Tag = frm
    newOp.Click += sinFun
    frm.addedOperationsToolStripMenuItem.DropDownItems.Add(newOp)