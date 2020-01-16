using Xamarin.Forms;

namespace PrismBindable.ViewModels
{
    public class TechItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DefaultTemplate { get; set; }
        public DataTemplate XamarinFormsTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return (string)item == "Xamarin.Forms" ? XamarinFormsTemplate : DefaultTemplate;
        }
    }
}
