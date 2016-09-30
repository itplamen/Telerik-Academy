namespace _01.Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Node<T>
    {
        private T value;
        private bool hasParrent;
        private List<Node<T>> childrens;

        public Node(T value)
        {
            this.Value = value;
            this.HasParrent = false;
            this.Childrens = new List<Node<T>>();
        }

        public T Value 
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value cannot be null!");
                }

                this.value = value;
            } 
        }

        public bool HasParrent 
        {
            get
            {
                return this.hasParrent;
            }

            set
            {
                this.hasParrent = value;
            } 
        }

        public List<Node<T>> Childrens 
        {
            get
            {
                return this.childrens;
            }

            set
            {
                this.childrens = value;
            }
        }

        public void AddChildren(Node<T> child)
        {
            this.Childrens.Add(child);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < this.Childrens.Count; i++)
            {
                builder.Append(this.Childrens[i].Value + " ");
            }

            return builder.ToString();
        } 
    }
}
