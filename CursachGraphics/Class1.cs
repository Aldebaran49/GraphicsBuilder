using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TreeNode
    {
        private TreeNode parent, left, right;
        private int type; // 0 - константа, 1 - переменная, 2 - бинарный оператор, 3 - унарный оператор
        string strvalue;
        double doublevalue = 0.0;
        TreeNode(TreeNode parent, int type, string value)
        {
            this.parent = parent;
            this.type = type;
            if (type == 0 )
            {
                doublevalue = double.Parse(value);
                this.strvalue = "NONE";
            }
            else
            {
                this.strvalue = value;
                this.doublevalue = -1;
            }
        }
    }
}
