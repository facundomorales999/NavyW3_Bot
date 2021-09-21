using System;
using System.Collections.Generic;

namespace Library
{
    public abstract class AbstractField : AbstractVesselSaver
    {
        private IField[,] _table;
        protected AbstractField(int x, int y)
        : base()
        {
            this._table = new IField[x, y];
            for (int j=0; j<y; j++)
            {
                for (int i=0; i<x; i++)
                {
                    this._table[i,j] = new AttackableWater();
                }
            }
        }
        public int XLength()
        {
            return this._table.GetLength(0);
        }
        public int YLength()
        {
            return this._table.GetLength(1);
        }
        public IField At(int x, int y)
        {
            return this._table[x, y];
        }
        protected void UpdateAt(int x, int y, IField data)
        {
            this._table[x, y] = data;
        }
        public bool IsEmpty()
        {
            for (int y = 0; y < this.YLength(); y++)
            {
                for (int x = 0; x < this.XLength(); x++)
                {
                    if (this._table[x, y] is LivedVessel ||
                        this._table[x, y] is LiveHiddenVessel)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsOrWasAVessel(int x, int y)
        {
            return this._table[x, y] is LiveHiddenVessel ||
                   this._table[x, y] is LivedVessel ||
                   this._table[x, y] is DeadVessel;
        }
        public bool IsAVessel(int x, int y)
        {
            return this._table[x, y] is LiveHiddenVessel ||
                   this._table[x, y] is LivedVessel;
        }
        public List<(int,int)> VesselCoordinates(int x, int y)
        {
            List<(int,int)> toReturn = new List<(int, int)> ();
            if (this.IsOrWasAVessel(x,y))
            {
                (int, int) aux = this.GetLeftUp(x,y);

                int xAux = aux.Item1;
                int yAux = aux.Item2;

                toReturn.Add((xAux,yAux));
                
                while (this.IsOrWasAVessel(xAux + 1, yAux))
                {
                    xAux = xAux + 1;
                    toReturn.Add((xAux,yAux));
                }
                while (this.IsOrWasAVessel(xAux, yAux + 1))
                {
                    yAux = yAux + 1;
                    toReturn.Add((xAux,yAux));
                }
            }
            return toReturn;
        }
        public (int, int) GetLeftUp(int x, int y)
        {
            int xAux = x;
            int yAux = y;
            
            while (this.IsOrWasAVessel(xAux - 1, yAux))
            {
                xAux = xAux - 1;
            }
            while (this.IsOrWasAVessel(xAux, yAux - 1))
            {
                yAux = yAux - 1;
            }

            return (xAux, yAux);
        }
        public bool AddVessel(int x, int y, AbstractVessel vessel, bool orientation)
        {
            // La orientacion se interpreta de la siguiente manera.
            // true - Vertical 
            // false - Horizontal
            int minX = x - 1;
            int minY = y - 1;
            int maxX;
            int maxY;
            if (orientation)
            {
                maxX = x + 1;
                maxY = y + vessel.Length();
            }
            else
            {
                maxX = x + vessel.Length();
                maxY = y + 1;
            }

            // Revisamos que el barco tenga el espacio suficiente en el tablero.
            // No se permiten barcos contra el borde.
            if (!(0 <= minX && maxX < this.XLength() && 0 <= minY && maxY < this.YLength()))
            {
                return false;
            }

            // Revisamos que el barco no se superponga con otro.
            for (int j = minY; j <= maxY; j++)
            {
                for (int i = minX; i <= maxX; i++)
                {
                    if (this.IsOrWasAVessel(i, j))
                    {
                        return false;
                    }
                }
            }

            // Colocamos el barco.
            if (orientation)
            {
                for (int j = y; j < y + vessel.Length(); j++)
                {
                    this.UpdateAt(x, j, new LiveHiddenVessel());
                }
            }
            else
            {
                for (int i = x; i < x + vessel.Length(); i++)
                {
                    this.UpdateAt(i, y, new LiveHiddenVessel());
                }
            }

            // Actualizo el diccionario. 
            this.AddVessel(x, y, vessel);
            return true;
        }
        public void RemoveVessel(int x, int y, IField data)
        {
            (int, int) aux = this.GetLeftUp(x, y);

            // Up y Left forman la posicion mas arriba y mas a la izquierda de un barco, 
            // lo que es nuestra clave en el diccionario.

            int left = aux.Item1;
            int  up = aux.Item2;

            this.RemoveVessel((left, up));

            int xAux = left;
            int yAux = up;

            while (this.IsOrWasAVessel(xAux, yAux))
            {
                this.UpdateAt(xAux, yAux, data);
                xAux = xAux + 1;
            }

            xAux = left;
            yAux = up;

            Console.WriteLine(left +" "+  up);

            while (this.IsOrWasAVessel(xAux, yAux))
            {
                this.UpdateAt(xAux, yAux, data);
                yAux = yAux + 1;
            }
        }
    }
}