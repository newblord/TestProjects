using System.Collections.Generic;

namespace SqlFormatter.ParseStructure
{
    public interface Node
    {
        string Name { get; }
        string TextValue { get; }
        IDictionary<string, string> Attributes { get; }
        void SetAttribute(string name, string value);
        string GetAttributeValue(string name);
        void RemoveAttribute(string name);
        Node Parent { get; }
        IEnumerable<Node> Children { get; }
        void AddChild(Node child);
        void InsertChildBefore(Node newChild, Node existingChild);
        void RemoveChild(Node childThing);
    }
}
