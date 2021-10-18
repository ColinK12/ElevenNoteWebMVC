using System;

namespace ElevenNote.WebMVC.Controllers
{
    internal class NoteService
    {
        private Guid userId;

        public NoteService(Guid userId)
        {
            this.userId = userId;
        }
    }
}