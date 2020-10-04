using System;
using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class MovieModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _director;
        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private GenreEntity _genre;
        public GenreEntity Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private DateTime _createAt;
        public DateTime CreateAt
        {
            get { return _createAt; }
            set { _createAt = value == null ? DateTime.UtcNow : value; }
        }

        private DateTime? _updateAt;
        public DateTime? UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }

        private bool _removed;
        public bool Removed
        {
            get { return _removed; }
            set { _removed = value; }
        }




    }
}
