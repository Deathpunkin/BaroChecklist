using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaroChecklist
{
    static class TreeViewExtensions
    {
        public static IEnumerable<TreeNode> Children(this TreeNode node)
        {
            foreach (TreeNode n in node.Nodes)
            {
                yield return n;

                foreach (TreeNode child in Children(n))
                    yield return child;
            }
        }

        public static IEnumerable<TreeNode> Parents(this TreeNode node)
        {
            var p = node.Parent;

            while (p != null)
            {
                yield return p;

                p = p.Parent;
            }
        }
    }

    public static class Extensions
    {
        public static ItemInfo ReturnKeyIfValueExist(this Dictionary<string, ItemInfo> dict, string _value)
        {
            if (dict.ContainsKey(_value))
            {
                return dict[_value];
            }
            else
            {
                return ItemInfo.Blank();
            }
        }

        public static string ToTitleCase(this string stringToConvert)
        {
            string firstChar = stringToConvert[0].ToString();
            return (stringToConvert.Length > 0 ? firstChar.ToUpper() +
                stringToConvert.Substring(1) : stringToConvert);
        }
    }
}