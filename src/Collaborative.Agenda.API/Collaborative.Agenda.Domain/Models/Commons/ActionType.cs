namespace Collaborative.Agenda.Domain.Models.Commons
{
    public enum ActionType
    {
        // Gain points
        Login = 1,
        AddEvent = 2,
        AddFriend = 3,
        ReportEvent = 4,
        CommentEvent = 5,
        AnswerFriendshipRequest = 6,
        CheckIn = 7,
        AddShedule = 12,
        // Lose points
        DeleteEvent = 8,
        RemoveFriend = 9,
        HasReportedEvent = 10,
        DeleteComment = 11,
        DeleteShedule = 13
    }
}
