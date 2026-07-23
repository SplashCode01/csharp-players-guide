using System;
using System.Collections.Generic;
using System.Text;

namespace FountainObjects
{
	public class Map
	{
		private readonly RoomType[,] _rooms;

		public int Rows { get; }
		public int Columns { get; }

		// NOTE: We set room type in the Game class for easier control of game type (small, medium, large)
		public Map(int columns, int rows)
		{
			Rows = rows;
			Columns = columns;
			_rooms = new RoomType[columns, rows];
		}

        public bool IsOnMap(Location location) =>
			location.Row >= 0 &&
			location.Row < _rooms.GetLength(0) &&
			location.Column >= 0 &&
			location.Column < _rooms.GetLength(1);

		// TODO: HasNeighborWithType

        public RoomType GetRoomType(Location location) => IsOnMap(location) ? _rooms[location.Row, location.Column] : RoomType.OffMap;
        public void SetRoomType(Location location, RoomType type) => _rooms[location.Row, location.Column] = type;
    }
}