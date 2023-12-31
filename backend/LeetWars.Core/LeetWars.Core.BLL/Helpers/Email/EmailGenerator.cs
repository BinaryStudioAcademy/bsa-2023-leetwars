﻿using LeetWars.Core.Common.DTO.Mail;

namespace LeetWars.Core.BLL.Helpers.Email
{
    public static class EmailGenerator
    {
        private static string GenerateEmailMarkup(string? username)
        {
            var markup = $@"<div style=""font-family: Arial, sans-serif; margin: 0; padding: 0;"">
                                <div style=""max-width: 600px; margin: auto; background-color: #1D1E21; color: #fff; text-align: center; padding: 20px;"">
                                    <img src=""https://i.imgur.com/LUeMV2n.png"" alt=""LEETWARS"" style=""max-width: 100%; height: auto;"">
                                    <h1>Welcome <span style=""font-weight: bold;"">{username ?? "dear user"}</span>,</h1>
                                </div>
                                <div style=""max-width: 600px; margin: auto; padding: 20px; color: #fff; text-align: justify; background-color: #777777;"">
                                    <p style=""font-size: 18px;"">We welcome you to the Leetwars community! We are delighted to greet you among our talented
                                         developers and programmers from around the world. You've made the right choice by joining our platform, 
                                         where you can enhance your programming skills and tackle interesting challenges.</p>
                                    <p style=""font-size: 18px;"">We wish you success in your programming endeavors and an enjoyable experience on 
                                        our platform.</p>
                                </div>
                                <div style=""max-width: 600px; margin: auto; padding: 10px 20px; color: #fff; background-color: #777777;"">
                                    <p style=""font-size: 20px; font-weight: bold; text-align: center"">Best, The Leetwars Team</p>
                                </div>
                            </div>";
            return markup;
        }

        public static MailDto GenerateWelcomeEmail(string? username, string userEmail)
        {
            var mail = new MailDto
            {
                Subject = "Welcome to Leetwars Community",
                Content = GenerateEmailMarkup(username),
                ReceiverEmail = userEmail,
            };
            return mail;
        }
    }
}
