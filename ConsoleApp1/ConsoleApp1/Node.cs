using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV
{
    class Node
    {

        public DocGia giatri;      // Giá trị node
        public Node left;       // Node pLeft
        public Node right;      // Node pRight

        // Hàm tạo không đối số
        public Node()
        {

            this.left = null;
            this.right = null;

        }
        // Hàm tạo có đối số là giá trị node
        public Node(DocGia a)
        {

            this.giatri = a;
            this.left = null;
            this.right = null;

        }
    }
}
