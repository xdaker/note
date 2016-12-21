#限制WPF的TextBox只能输入数字
**首先TextBox有一个叫TextChanged的事件，当文本框的内容发生改变时触发。**

     <TextBox Width="50" TextChanged ="TextBoxBase_OnTextChanged" Text="{Binding Value, > >  ElementName=WidthSlider }"/>
**思路是这样：当文本框的内容发生改变时，我们就获取文本框的值，然后在通过正则表达式去判断输入的文本是否符合我们的要求**

       private void TextBoxBase_OnTextChanged(object sender,
            TextChangedEventArgs e)
        {
          TextBox textBox = sender as TextBox;
          if (textBox == null) return;
          Regex re = new Regex("[0-9]" + "{" + textBox.Text.Length + "}");
          e.Handled = !re.IsMatch(textBox.Text);//Handled为False时是允许键盘的值输入，这可以阻止键盘的输入，但是去没有办法阻止输入法的输入
          if (e.Handled)//这步是为了阻止输入法的输入
            {
                textBox.Text = 文本改变前的值;
            }
        }