using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Memento_Real_UndoRedo_DP
{
    public class TextEditor
    {
        private string _content = "";

        public void Write(string text)
        {
            _content += text;
            Console.WriteLine($"[Viết] Nội dung hiện tại: {_content}");
        }

        public TextMemento Save()
        {
            Console.WriteLine("[Lưu] Đã lưu trạng thái văn bản.");
            return new TextMemento(_content);
        }

        public void Restore(TextMemento memento)
        {
            _content = memento.Content;
            Console.WriteLine($"[Undo] Đã phục hồi về: {_content}");
        }
    }
}
