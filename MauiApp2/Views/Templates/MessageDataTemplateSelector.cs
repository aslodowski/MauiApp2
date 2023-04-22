using MauiApp2.Models;

namespace MauiApp2.Views.Templates
{
    internal class MessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SenderMessageTemplate { get; set; }
        public DataTemplate ReceiverMessageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = (MessageDummy)item;

            if (message.Sender == null)
                return ReceiverMessageTemplate;

            return SenderMessageTemplate;
        }
    }
}
