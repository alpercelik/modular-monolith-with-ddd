﻿using CompanyName.MyMeetings.BuildingBlocks.Domain;
using CompanyName.MyMeetings.Modules.Meetings.Domain.Members;

namespace CompanyName.MyMeetings.Modules.Meetings.Domain.Meetings.Events;

public class MeetingWaitlistMemberAddedDomainEvent : DomainEventBase
{
    public MeetingWaitlistMemberAddedDomainEvent(MeetingId meetingId, MemberId memberId)
    {
        MeetingId = meetingId;
        MemberId = memberId;
    }

    public MeetingId MeetingId { get; }

    public MemberId MemberId { get; }
}