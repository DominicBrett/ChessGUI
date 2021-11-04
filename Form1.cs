﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessBoardModel;

namespace ChessGUI
{
    public partial class Form1 : Form
    {
        private static  Board board = new Board(8);

        public Button[,] btnGrid = new Button[board.Size, board.Size];
        public Form1()
        {
            InitializeComponent();
            PopulateGird();
        }

        public void PopulateGird()
        {
            // create buttons and place in panel 1
            int buttonSize = panel1.Width / board.Size;

            panel1.Height = panel1.Width;

            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    btnGrid[i, j] = new Button();

                    btnGrid[i, j].Height = buttonSize;
                    btnGrid[i, j].Width = buttonSize;

                    //add click event to button
                    btnGrid[i, j].Click += Grid_Button_Click;

                    panel1.Controls.Add(btnGrid[i,j]);

                    btnGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    
                    btnGrid[i, j].Tag = new Point(i, j);
                }
            }
            RenderChessPieces();

        }
        public void RenderChessPieces()
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.TheGrid[i, j].CurrentPiece != null)
                    {
                            if (board.TheGrid[i, j].CurrentPiece.PieceType != null)
                            {
                                btnGrid[i, j].Text = board.TheGrid[i, j].CurrentPiece.PieceType;
                            }
                    }
                    else
                    {
                        btnGrid[i, j].Text = "";
                    }
                }
            }
        }

        public void RenderLegalmoves()
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    if (board.TheGrid[i, j].IsLegalNextMove)
                    {
                        if (!board.TheGrid[i, j].IsCurrentlyOccupied)
                        {
                            btnGrid[i, j].BackColor = Color.LightSlateGray;
                        }
                        else
                        {
                            if (board.TheGrid[i, j].CurrentPiece != null)
                            {
                                if (!board.TheGrid[i, j].CurrentPiece.IsPlayerControlled)
                                {
                                    btnGrid[i, j].BackColor = Color.Yellow;
                                }
                            }

                        }
                    }
                    else if (!board.TheGrid[i, j].IsCurrentlyOccupied)
                    {
                        btnGrid[i, j].Text = "";
                    }
                }
            }
        }
   
        private void Grid_Button_Click(object? sender, EventArgs e)
        {
            //Get the x and y of the button
            Button button = (Button) sender;
            Point location = (Point) button.Tag;

            int x = location.X;
            int y = location.Y;

            Cell cell = board.TheGrid[x, y];

            // Determine next legal moves
            if (board.TheGrid[x, y].CurrentPiece != null)
            {
                string piece = board.TheGrid[x, y].CurrentPiece.PieceType;
                board.MarkNextLegalMoves(board.TheGrid[x, y], piece);
            }
            else
            {
                board.MarkNextLegalMoves(board.TheGrid[x, y], null);
            }
            RenderChessPieces();
            RenderLegalmoves();
        }
    }
}
