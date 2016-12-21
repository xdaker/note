
#WPF获取Binding对象
--------------------------------------
**我们可以通过DataContext来获取相关联的对象，例如：**

     <TextBox Width="50" TextChanged ="TextBoxBase_OnTextChanged" Text="{Binding Value, ElementName=WidthSlider }"/>
     <Slider Name="WidthSlider" Value="{Binding Width}" Minimum="700" Maximum="3600" Width="212"/>

**如果有一个类叫做Model里面有个属性是Width，那么WidthSlider.DataContext = Model时，Slider 的Value就和Model.Width相关联了。这时候不管是TextBox.DataContext 还是Slider.DataContext的对象都是Model。 **
**那么怎么获取TextBox 关联的Slider 对象呢？**
**我们可以通过静态方法 BindingOperations.GetBindingExpression来获取**

                BindingExpression bindingExpression =
                BindingOperations.GetBindingExpression(textBox,//textBox是一个TextBox的对象
                    TextBox.TextProperty);//所关联的属性依赖，这里关联的属性是Text，所以属性依赖是TextProperty。（TextBox是静态的）
            var slider = bindingExpression?.DataItem as Slider;//通过强制类型转换，我们就可以得到Slider对象