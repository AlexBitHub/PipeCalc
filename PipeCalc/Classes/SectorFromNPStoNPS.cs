using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeCalc
{
    public class SectorFromNPStoNPS
    {
        public Pipeline pipe;
        public Station station;
        public List<int> X_SpotsSector;
        public List<int> Z_SpotsSector;

        public float EndPoint;
        public SectorFromNPStoNPS (Pipeline pipe, Station station)
        {
            this.pipe = pipe; this.station = station;
        }
        public void GetListPoints()
        {
            
            X_SpotsSector = (from x in pipe.XSpots
                             where x >= station.Coordinate && x <= EndPoint
                             select x).ToList();
            Z_SpotsSector = pipe.XSpots.Where(x => x >= station.Coordinate && x <= EndPoint).Select((x, i) => pipe.HighSpots[i]).ToList();

            //X_SpotsSector = (from x in pipe.HighAndCoordSpots.Keys
            //                where x >= station.Coordinate && x <= EndPoint
            //                select x).ToList();
            //Z_SpotsSector = (from x in pipe.HighAndCoordSpots
            //                 where x.Key >= station.Coordinate && x.Key <= EndPoint
            //                 select x.Value).ToList();
        }

    }

    public class Node
    {
        public Node(SectorFromNPStoNPS data)
        {
            Data = data;
        }
        public SectorFromNPStoNPS Data { get; set; }
        public Node Next { get; set; }
    }

    public class LinkedSectorFromNPStoNPS : IEnumerable<SectorFromNPStoNPS>
    {
        public Node head;
        public Node tail;
        int count;
        public int Count { get; set; }
        public bool IsEmpty { get { return count == 0; } }

        public void Add(SectorFromNPStoNPS data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                head.Data.EndPoint = head.Data.pipe.Length; // if first station, last point of sector is length of pipe
            }
            else
            {
                tail.Next = node;
                tail.Data.EndPoint = node.Data.station.Coordinate; // Last station gets new end point, that's coordinate new station.
                tail.Data.GetListPoints();
            }
            tail = node; // last node is new station
            tail.Data.EndPoint = head.Data.pipe.Length;
            tail.Data.GetListPoints();
            count++;
        }

        public bool Remove(SectorFromNPStoNPS data)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                // if not first NodeSectorFromNPStoNPS
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        // if last NodeSectorFromNPStoNPS
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = current.Next;
                        // if current.Next == null, i.e. there was only one element
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Clear()
        {
            head = null; tail = null; count = 0;
        }

        public bool Contains(SectorFromNPStoNPS data)
        {
            Node current = head;
            while(current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = head.Next;
            }
            return false;
        }
        public void AppendFirst(SectorFromNPStoNPS data)
        {
            Node node = new Node(data);
            node.Next = head; // if first element in list that's head is null
            
            if (count == 0)
            {
                tail = node;
                //tail.Data.EndPoint = tail.Data.pipe.Length;
            }
            if (count != 0)
            {
                head.Data.EndPoint = node.Data.station.Coordinate; // head changes EndPoint to endPoint new element
                head.Data.GetListPoints();
            }

            head = node;
            head.Data.EndPoint = head.Data.pipe.Length;
            head.Data.GetListPoints(); // after change element head
            count++;
        }
        public IEnumerator<SectorFromNPStoNPS> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
