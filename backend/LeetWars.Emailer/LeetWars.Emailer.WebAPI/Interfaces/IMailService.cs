﻿using LeetWars.Core.Common.DTO.Mail;

namespace LeetWars.Emailer.Interfaces
{
    public interface IMailService
    {
        Task<IResult> SendWithValidationCheckAsync(MailDto mailDto);
    }
}
