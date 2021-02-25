using Emitters;

namespace Mechanics
{
    public static class EmitterUser
    {
        public static void UseEmitter()
        {
            // problem here
            MagicEmitter.Emit(null);
        }
    }
}