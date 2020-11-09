using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Challenge358Hard
{
    struct PuzzlePiece
    {
        public int ID { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }

        public PuzzlePiece(int id, int top, int right, int bottom, int left) : this()
        {
            ID = id;
            Top = top;
            Right = right;
            Bottom = bottom;
            Left = left;
        }
    }

    public partial class Form358Hard : Form
    {
        public Form358Hard()
        {
            InitializeComponent();
        }

        void BtnSolve_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Lines;

            Size puzzleSize = GetSize(input[0]);
            var puzzlePieces = GetPieces(input);

            var solver = new PuzzleSolver();
            var puzzleBase = solver.SolvePuzzle(puzzlePieces, puzzleSize);

            listOutput.Items.Clear();

            for (int row = 0; row < puzzleSize.Height; row++)
            {
                string rowPieces = "";

                for (int column = 0; column < puzzleSize.Width; column++)
                {
                    rowPieces += puzzleBase[row, column].ID + "\t";
                }

                listOutput.Items.Add(rowPieces);
            }
        }

        Size GetSize(string puzzleInput)
        {
            string[] pieceStr = puzzleInput.Split(',');

            return new Size(int.Parse(pieceStr[0].Trim()), int.Parse(pieceStr[1].Trim()));
        }

        List<PuzzlePiece> GetPieces(string[] puzzleInput)
        {
            List<PuzzlePiece> puzzlePieces = new  List<PuzzlePiece>();
            char[] delimiters = new char[] { ':', ',' };

            for (int i = 1; i < puzzleInput.Length; i++)
            {
                var piece = puzzleInput[i].Split(delimiters).Select(s => int.Parse(s)).ToArray();

                puzzlePieces.Add(new PuzzlePiece(piece[0], piece[1], piece[2], piece[3], piece[4]));
            }

            return puzzlePieces;
        }
    }

    class PuzzleSolver
    {
        Size _puzzleSize;
        PuzzlePiece[,] _puzzleBase;

        HashSet<PuzzlePiece> _availablePieces = new HashSet<PuzzlePiece>();

        Dictionary<int, List<PuzzlePiece>> _topSideToPieces = new Dictionary<int, List<PuzzlePiece>>();
        Dictionary<int, List<PuzzlePiece>> _leftSideToPieces = new Dictionary<int, List<PuzzlePiece>>();


        public PuzzlePiece[,] SolvePuzzle(List<PuzzlePiece> pieces, Size puzzleSize)
        {
            _puzzleBase = new PuzzlePiece[puzzleSize.Width, puzzleSize.Height];
            _puzzleSize = puzzleSize;

            foreach (var piece in pieces)
            {
                _availablePieces.Add(piece);
                AddPieceToDictionaries(piece);
            }

            var matchesTop = _topSideToPieces[0];
            var matchesLeft = _leftSideToPieces[0];
            var firstPiece = matchesTop.Intersect(matchesLeft).FirstOrDefault();

            foreach (var piece in pieces)
                if (CheckPiece(firstPiece, 0, 0))
                    return _puzzleBase;

            throw new ArgumentException();
        }

        bool CheckPiece(PuzzlePiece piece, int row, int column)
        {
            if (IsValid(piece, row, column))
            {
                _availablePieces.Remove(piece);
                _puzzleBase[row, column] = piece;

                if (row == _puzzleSize.Height - 1 && column == _puzzleSize.Width - 1)
                    return true;

                bool lastColumn = column == _puzzleSize.Width - 1;
                int nextRow = lastColumn ? row + 1 : row;
                int nextColumn = lastColumn ? 0 : column + 1;

                List<PuzzlePiece> matchesTop;
                List<PuzzlePiece> matchesLeft;

                if (nextRow == 0)
                {
                    matchesTop = _topSideToPieces[0];
                    matchesLeft = _leftSideToPieces[piece.Right * -1];
                }
                else if (nextColumn == 0)
                {
                    matchesTop = _topSideToPieces[_puzzleBase[nextRow - 1, nextColumn].Bottom * -1];
                    matchesLeft = _leftSideToPieces[0];
                }
                else
                {
                    matchesTop = _topSideToPieces[_puzzleBase[nextRow - 1, nextColumn].Bottom * -1];
                    matchesLeft = _leftSideToPieces[piece.Right * -1];
                }

                var nextPieces = matchesTop.Intersect(matchesLeft).ToList();

                foreach (var nextPiece in nextPieces)
                {
                    if (!_availablePieces.Contains(nextPiece))
                        continue;

                    if (CheckPiece(nextPiece, nextRow, nextColumn))
                    {
                        return true;
                    }
                }

                _availablePieces.Add(piece);
            }

            return false;
        }

        void AddPieceToDictionaries(PuzzlePiece piece)
        {
            if (!_topSideToPieces.ContainsKey(piece.Top))
                _topSideToPieces.Add(piece.Top, new List<PuzzlePiece>());
            _topSideToPieces[piece.Top].Add(piece);

            if (!_leftSideToPieces.ContainsKey(piece.Left))
                _leftSideToPieces.Add(piece.Left, new List<PuzzlePiece>());
            _leftSideToPieces[piece.Left].Add(piece);
        }

        bool IsValid(PuzzlePiece piece, int row, int column)
        {
            if (row == 0 && piece.Top != 0)
                return false;
            if (row == _puzzleSize.Height - 1 && piece.Bottom != 0)
                return false;
            if (column == 0 && piece.Left != 0)
                return false;
            if (column == _puzzleSize.Width - 1 && piece.Right != 0)
                return false;

            if (row != 0 && piece.Top + _puzzleBase[row - 1, column].Bottom != 0)
                return false;
            if (column != 0 && piece.Left + _puzzleBase[row, column - 1].Right != 0)
                return false;

            return true;
        }
    }
}
