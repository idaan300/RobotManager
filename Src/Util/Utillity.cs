using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using FastColoredTextBoxNS;

namespace RobotMananager;

public static class Utility {

    /// <summary>
    /// Managed Struct -> Managed Byte Array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="str"></param>
    /// <returns></returns>
   public static Byte[] MStrToBytes<T>(Object str) {
        Int32 size = Marshal.SizeOf(str);
        byte[] arr = new byte[size];

        IntPtr ptr = IntPtr.Zero;
        try {
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(str, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
        }
        finally {
            Marshal.FreeHGlobal(ptr);
        }
        return arr;
   }
    /// <summary>
    /// Given A Byte Array Print Out Its Contents In A Formated Manner
    /// </summary>
    /// <param name="Data"></param>
    /// <param name="BPL"></param>
    /// <returns></returns>
    public static String HexDump(Byte[] Data, Int32 BPL = 16) {
        if (Data == null)
            return "<null>";
        Int32 BLen = Data.Length;

        Char[] HexChars = "0123456789ABCDEF".ToCharArray();

        Int32 FHexCol =
              8                   // 8 characters for the address
            + 3;                  // 3 spaces

        Int32 FCharCol = FHexCol
            + BPL * 3       // - 2 digit for the hexadecimal value and 1 space
            + (BPL - 1) / 8 // - 1 extra space every 8 characters from the 9th
            + 2;                  // 2 spaces 

        Int32 LineLen = FCharCol
            + BPL           // - characters to show the ascii value
            + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

        Char[] Line = (new String(' ', LineLen - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
        Int32 ExLines = (BLen + BPL - 1) / BPL;
        StringBuilder Res = new(ExLines * LineLen);

        for (int i = 0; i < BLen; i += BPL) {
            Line[0] = HexChars[(i >> 28) & 0xF];
            Line[1] = HexChars[(i >> 24) & 0xF];
            Line[2] = HexChars[(i >> 20) & 0xF];
            Line[3] = HexChars[(i >> 16) & 0xF];
            Line[4] = HexChars[(i >> 12) & 0xF];
            Line[5] = HexChars[(i >> 8) & 0xF];
            Line[6] = HexChars[(i >> 4) & 0xF];
            Line[7] = HexChars[(i >> 0) & 0xF];

            Int32 HexCol = FHexCol;
            Int32 CharCol = FCharCol;

            for (Int32 j = 0; j < BPL; j++) {
                if (j > 0 && (j & 7) == 0)
                    HexCol++;
                if (i + j >= BLen) {
                    Line[HexCol] = ' ';
                    Line[HexCol + 1] = ' ';
                    Line[CharCol] = ' ';
                }
                else {
                    Byte B = Data[i + j];
                    Line[HexCol] = HexChars[(B >> 4) & 0xF];
                    Line[HexCol + 1] = HexChars[B & 0xF];
                    Line[CharCol] = (B < 31 ? '·' : (Char)B);
                }
                HexCol += 3;
                CharCol++;
            }
            Res.Append(Line);
        }
        return Res.ToString();
    }


}

public class TextBoxStreamWriter : TextWriter {
    private readonly FastColoredTextBox Output;

    public TextBoxStreamWriter(FastColoredTextBox output) => Output = output;
    
    public override void Write(char value) {
        base.Write(value);
        //Console.Write uses Windows Line Endings (CRLF) Our Textbox Uses Unix Line Endings.
        //This Causes Double Line Spacing.
        //Each Char Is Given Sepperatly. We Can Use Trim To Effectively Filter Out This CR
        Output.AppendText(value.ToString().Trim('\r'));         //Write To TextBox
    }

    public override Encoding Encoding {
        get { return Encoding.Default; }
    }
}