using System.Collections.ObjectModel;
using WhatsAppMAUI.Models;

namespace WhatsAppMAUI.Pages;

public partial class ChatsPage : ContentPage
{
	public ChatsPage()
	{
		InitializeComponent();
        Chats = new ObservableCollection<ChatModel>(LoadChats());

        BindingContext = this;
	}

    public ObservableCollection<ChatModel> Chats { get; set; }

    private static IEnumerable<ChatModel> LoadChats()
	{
		return new List<ChatModel>
		{
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
            new ChatModel(("avatar_group.svg"), "Akp Tech", DateTime.Now.AddDays(-2), "Just a test message", 0),
            new ChatModel(("avatar_group.svg"), "Expenses", DateTime.Now, "Grocery 500", 0),
            new ChatModel(("avatar.svg"), "Baby", DateTime.Now.AddMinutes(-2), "Honey, when will you", 1),
            new ChatModel(("avatar_group.svg"), "Office", DateTime.Now.AddDays(-1), "Ready to launch", 10),
        };
	}
}