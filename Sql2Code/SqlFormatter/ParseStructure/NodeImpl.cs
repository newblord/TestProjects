using System;
using System.Collections.Generic;
using System.Linq;

namespace SqlFormatter.ParseStructure
{
    internal class NodeImpl : Node
    {
        public NodeImpl()
        {
            Attributes = new Dictionary<string, string>();
            Children = new List<Node>();
        }

        public string Name { get; set; }
        public string TextValue { get; set; }
        public Node Parent { get; set; }

        public IDictionary<string, string> Attributes { get; private set; }
        public IEnumerable<Node> Children { get; private set; }

        public void AddChild(Node child)
        {
            SetParentOnChild(child);
            ((IList<Node>)Children).Add(child);
        }

        public void InsertChildBefore(Node newChild, Node existingChild)
        {
            SetParentOnChild(newChild);
            var childList = Children as IList<Node>;
            childList.Insert(childList.IndexOf(existingChild), newChild);
        }

        private void SetParentOnChild(Node child)
        {
            //TODO: NOT THREAD-SAFE AT ALL!
            if (child.Parent != null)
                throw new ArgumentException("Child cannot already have a parent!");
            ((NodeImpl)child).Parent = this;
        }

        public void RemoveChild(Node child)
        {
            //TODO: NOT THREAD-SAFE AT ALL!
            ((IList<Node>)Children).Remove(child);
            ((NodeImpl)child).Parent = null;
        }


        public string GetAttributeValue(string aName)
        {
            string outVal = null;
            Attributes.TryGetValue(aName, out outVal);
            return outVal;
        }

        public void SetAttribute(string name, string value)
        {
            Attributes[name] = value;
        }

        public void RemoveAttribute(string name)
        {
            Attributes.Remove(name);
        }

    }
}
