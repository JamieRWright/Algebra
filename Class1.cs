using System;
using System.Collections.Generic;
using System.Numerics;


namespace Algebra
{
    public abstract class NumberSets 
    {
        private readonly Type _type;//The C# type to work with
        private List<Boolean> _conditions;
        public Type getType { get { return _type; } } 
    }
    public class Naturals : NumberSets
    {
        private Type _type = typeof(int);
        public List<Boolean> conditions;
    }
    public class Integers : NumberSets
    {
        private Type _type = typeof(int);
        public List<Boolean> conditions;
    }
    public class Reals : NumberSets
    {
        private Type _type = typeof(float);
        public List<Boolean> conditions;
    }
    public class Class1
    {
    }
    public class Set
    {
        private Type _type;
        private Element[] _elements;
        public Set(Type inType)
        {
            _type = inType;
        }
        public int Cardinality { get { return _elements.Length; } }
    }
    public class Element
    {
        private Type _type;
    }
    public abstract class Operator
    {
        public static List<Type> Operations;
        public char getOperation { get; }
        public abstract Element doOperations(Element inElement1, Element inElement2);
    }
    public abstract class Addition : Operator
    {
        public char GetOperation
        {
            get { return '+'; }
        }
        public override Element doOperations(Element inElement1, Element inElement2)
        {
            return default;
        }
    }
    public class Group
    {
        private Operator _operator;
        private Element _identity;
        private Set _group;

        public Group(Set inSet, Element inID, Operator inOperator)
        {
            _group = inSet;
            _identity = inID;
            _operator = inOperator;
        }
        public Set inverse(Element inElement)
        {
            return default(Set);
        }
        private bool isID(Set inID)
        {
            int i = 0;
            bool valid = true;
            do
            {
            } while (valid || i == _group.Cardinality);
            return valid;
        }
    }
}
