using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNetLabb1
{
    internal class BoxCollection : ICollection<Box>
    {

        private List<Box> _innerCol;

        public BoxCollection() { _innerCol = new List<Box>(); }

        public Box this[int index]
        {
            get { return _innerCol[index]; }
            set { _innerCol[index] = value; }
        }

        public int Count
        {
            get { return _innerCol.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Box item)
        {
            string msg;
            if (!Contains(item, out msg))
            {
                _innerCol.Add(item);
            }
            else
            {
                Console.WriteLine(msg + " Only unique objects may be added to list.");
            }
        }

        public void Clear()
        {
            _innerCol.Clear();
        }

        public bool Contains(Box item)
        {
            foreach (Box box in _innerCol)
            {
                if (new BoxSameDimensions().Equals(box, item))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Contains(Box item, out string msg)
        {
            msg = "";
            foreach (Box box in _innerCol)
            {
                if (new BoxSameDimensions().Equals(box, item))
                {
                    msg = "The collection contains a box with these dimensions.";
                    return true;
                }
                else if (new BoxSameVolume().Equals(box, item))
                {
                    msg = "The collecton contains a box with this volume.";
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array can not be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Array index can not be " +
                    "negative");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer " +
                    "elements than the collection.");
            }

            for (int i = 0; i < _innerCol.Count; i++)
            {
                array[i + arrayIndex] = _innerCol[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnum(this);
        }

        public bool Remove(Box item)
        {
            for (int i = 0; i < _innerCol.Count; i++)
            {
                Box tempBox = _innerCol[i];
                if (new BoxSameDimensions().Equals(tempBox, item))
                {
                    _innerCol.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
