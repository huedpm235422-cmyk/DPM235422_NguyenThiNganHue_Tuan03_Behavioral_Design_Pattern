using System.Collections;

namespace DPM235422_Hue_Tuan3_Iterator_DP
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();
        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}