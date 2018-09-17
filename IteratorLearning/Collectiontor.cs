using System.Collections;

public class Collectiontor : IEnumerator
{
    private int[] m_iArray1 = new int[3] { 1, 2, 3 };
    private int[] m_iArray2 = new int[3] { 4, 5, 6 };
    private int m_index = -1;


    public System.Object Current
    {
        get
        {
            if (m_index < m_iArray1.Length)
                return m_iArray1[m_index];
            else if (m_index < m_iArray1.Length + m_iArray2.Length)
                return m_iArray2[m_index - m_iArray1.Length];
            else
                return null;
        }
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }


    public bool MoveNext()
    {
        m_index += 1;
        return m_index < m_iArray1.Length + m_iArray2.Length;
    }

    public void Reset()
    {

    }
}
