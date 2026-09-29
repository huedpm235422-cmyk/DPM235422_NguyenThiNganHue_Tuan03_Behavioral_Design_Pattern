using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Memento_Real_UndoRedo_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- MEMENTO PATTERN (THỰC TẾ: UNDO VĂN BẢN) ---\n");

            TextEditor editor = new TextEditor();
            History history = new History();

            editor.Write("Xin chào! ");
            history.Push(editor.Save());

            editor.Write("Hôm nay trời ");
            history.Push(editor.Save());

            editor.Write("rất xấu."); // Viết nhầm

            Console.WriteLine("\n=> Khách hàng bấm nút UNDO:");
            editor.Restore(history.Pop()); // Phục hồi về trạng thái trước đó

            Console.ReadLine();
        }
    }
}
