using System.Collections.Generic;

namespace GameOfLifeCSharp
{
    /// <summary>
    /// A játéktér tábláját tárolja és kezeli
    /// </summary>
    class Table
    {
        private List<List<Field>> space;
        private int sizeX, sizeY;
        /// <summary>
        /// A létrehozó konstruktor
        /// </summary>
        /// <param name="sizeX">A létrehozandó tábla szélessége</param>
        /// <param name="sizeY">A létrehozandó tábla magassága</param>
        public Table(int sizeX, int sizeY)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.space = new List<List<Field>>();
        }
        /// <summary>
        /// A mezők legenerálása
        /// TODO: véletlen sziklák lehelyezése
        /// </summary>
        private void generateTable()
        {
            for (int i = 0; i < this.sizeX; i++)
            {
                List<Field> newRow = new List<Field>();
                for (int j = 0; i < this.sizeY; j++)
                {
                    newRow.Add(new Field());
                }
                this.space.Add(newRow);
            }
        }
    }
}
