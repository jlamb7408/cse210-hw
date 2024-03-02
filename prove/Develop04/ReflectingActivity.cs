class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(int duration):
    base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = new List<string> { "Think of a time you helped someone or made a difference in their life.", "Think of a time you made a positive change in your life.", "Think of a time you accomplsihed something relly difficult." };
        _questions = new List<string> { "Why is this exspierence meaningful to you?", "How did you feel during this exspierence?", "What can you learn from this exsperience?", "How do you think this exsperience has affected your life?", "How has exspereince affected others involved in it?" };

    }

    public void RunActivity()
    {
        
    }
}