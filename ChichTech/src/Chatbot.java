import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextArea;
import javax.swing.JScrollPane;

import java.awt.event.KeyListener; //monitors when you press "enter" to input words
import java.awt.event.KeyEvent;
import java.awt.Color; //background color
import java.awt.Font;
import java.lang.Math;

public class Chatbot extends JFrame implements KeyListener {
    JPanel p = new JPanel();
    // dialog is not editable, input is editable
    JTextArea dialog = new JTextArea(20, 50); // dialog contains the whole conversation
    JTextArea input = new JTextArea(1, 50); // input your quotes for the conversation
    JScrollPane scroll = new JScrollPane(dialog, JScrollPane.VERTICAL_SCROLLBAR_AS_NEEDED,
            JScrollPane.HORIZONTAL_SCROLLBAR_NEVER

    ); // Never scroll horizontally, scroll vertical as needed

    // create a 2D array that contains all the phrases you can say and react to
    String[][] chatBot = {
            // Standard Greetings (Group 1)
            { "hi", "hello", "good morning" }, // if one of these words are inputed..
            { "hey", "hi", "hello" }, // chatbot will say one of these things at random

            // question greetings, GROUP 2
            /*Your code here*/

            // generic responses, GROUP 3
            /*Your code here*/

            // default, triggered if none of the greetings above are inputed, GROUP 4
            /*Your code here*/

             };

    public static void main(String[] args) {
        new Chatbot(); // activates constructor method
    }

    public Chatbot() {
        super("ChichTech Chat Bot"); // title is ChatBot
        setSize(600, 400);
        setResizable(false);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        dialog.setEditable(false);
        // makes sure key listeners respond to inputs
        // triggers keyListeners in this class, not some other class
        input.addKeyListener(this);
        p.add(scroll);
        p.add(input);
        add(p);

        Color color = new Color(155, 0, 0);
        dialog.setForeground(color);
        input.setForeground(color);
        p.setBackground(Color.pink); // set background color of panel
        setVisible(true); // JFrame objects are not visible by default
    }

    // since you implemented KeyListener, all the methods for KeyListener will have
    // to be written
    public void keyPressed(KeyEvent e) {
        // only do anything if the key you pressed was "enter"
        if (e.getKeyCode() == KeyEvent.VK_ENTER) { // VK_ENTER is constant that represents key "enter"
            input.setEditable(false);
            // ----grab quote from input----------
            String quote = input.getText();
            // clear text in input so you can type more stuff
            input.setText("");


            // check for punctuation
            while (quote.charAt(quote.length() - 1) == '!' || quote.charAt(quote.length() - 1) == '.'
                    || quote.charAt(quote.length() - 1) == '?') {
                // take away punctuation
                quote = quote.substring(0, quote.length() - 1);
            }
            // quote = quote.trim();
        }

    }

    public void keyReleased(KeyEvent e) {
        /*Your code here*/
    }

    public void keyTyped(KeyEvent e) {
    }

    public void addText(String str) {
       /*Your code here*/
    }

    public boolean inArray(String input, String[] str) {
        /*Your code here*/
        return true;
    }

}
