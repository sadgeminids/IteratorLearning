using System.Collections;

// Please ignore box and unbox, this is just an example
public class Collectionable : IEnumerable
{

    private int[] m_iArray1 = new int[3] { 1, 2, 3 };
    private int[] m_iArray2 = new int[3] { 4, 5, 6 };


    public IEnumerator GetEnumerator()
    {
        return new CollectionEnumrator(this);
    }


    public class CollectionEnumrator : IEnumerator
    {

        private Collectionable m_collection;
        private int m_index = -1;

        public CollectionEnumrator(Collectionable collection)
        {
            m_collection = collection;
        }

        public System.Object Current
        {
            get
            {
                if (m_index < m_collection.m_iArray1.Length)
                    return m_collection.m_iArray1[m_index];
                else if (m_index < m_collection.m_iArray1.Length + m_collection.m_iArray2.Length)
                    return m_collection.m_iArray2[m_index - m_collection.m_iArray1.Length];
                else
                    return null;
            }
        }

        public bool MoveNext()
        {
            m_index += 1;
            return m_index < m_collection.m_iArray1.Length + m_collection.m_iArray2.Length;
        }

        public void Reset()
        {

        }

    }
}

