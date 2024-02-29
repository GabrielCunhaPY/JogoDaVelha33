using System;
using System.Drawing;

public class jogoDaVelha
{
    private Button[] buttons;
    private bool currentPlayer;

    public jogoDaVelha(Button[] buttons)
    {
        this.buttons = buttons;
        currentPlayer = true; // T = X, F = O
    }

    public bool seGanha()
    {
        // Check rows
        for (int i = 0; i <= 6; i += 3)
            if (buttons[i].Text == buttons[i + 1].Text && buttons[i + 1].Text == buttons[i + 2].Text && buttons[i].Text != "")
                return true;

        // Check columns
        for (int i = 0; i <= 2; i++)
            if (buttons[i].Text == buttons[i + 3].Text && buttons[i + 3].Text == buttons[i + 6].Text && buttons[i].Text != "")
                return true;

        // Check diagonals
        if (buttons[0].Text == buttons[4].Text && buttons[4].Text == buttons[8].Text && buttons[0].Text != "")
            return true;
        if (buttons[2].Text == buttons[4].Text && buttons[4].Text == buttons[6].Text && buttons[2].Text != "")
            return true;

        return false;
    }

    public void ChangePlayer()
    {
        currentPlayer = !currentPlayer;
    }

    public void SetButtonText(Button button, string text)
    {
        button.Text = text;
        button.Enabled = false;
    }

    public bool GetCurrentPlayer()
    {
        return currentPlayer;
    }
}