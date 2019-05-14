using System;
using System.Threading.Tasks;

namespace PeopleAreUs.Console.Output
{
    public abstract class RendererBase<T> : IRenderer<T>
    {
        public abstract Task RenderAsync(T data);

        protected async Task PrintInStyleAsync(string value, ConsoleColor textColor)
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            try
            {
                System.Console.ForegroundColor = textColor;
                await System.Console.Out.WriteAsync(value);
            }
            finally
            {
                System.Console.ResetColor();
            }
        }
    }
}