﻿using System.Windows;
using System.Windows.Input;
using MarkdownEdit.Controls;

namespace MarkdownEdit.Commands
{
    internal static class HelpCommand
    {
        public static readonly RoutedCommand Command = ApplicationCommands.Help;

        static HelpCommand()
        {
            Application.Current.MainWindow.CommandBindings.Add(new CommandBinding(Command, Execute));
        }

        private static void Execute(object sender, ExecutedRoutedEventArgs e)
        {
            var mainWindow = (MainWindow)sender;
            mainWindow.Editor.ToggleHelp();
        }
    }
}