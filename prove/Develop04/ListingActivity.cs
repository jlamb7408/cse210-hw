class ListingActivity: Activity
{   
    private List<string> _prompts;
    public ListingActivity(int duration):
    base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _prompts = new List<string> { "Who are people that you aperciate?", "What are your strenghts","How have you seen the Lord's hand in this last week?","What are you grateful for?", "What has been the highlihgt of your day every day this last week?","How have  you been able to help others this last week?" };
    }

public void RunActivity()
    {
        
    }
}