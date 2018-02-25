@Code
    ViewBag.Title = "Home Page"
End Code
@Html.DevExpress().Menu( _
    Sub(settings)
            settings.Name = "dxMenu"
            settings.Items.Add(Sub(item)
                                       item.Text = "Item 1"
                               End Sub)
            settings.Items.Add(Sub(item)
                                       item.Text = "Item 2"
                               End Sub)
            settings.Items.Add(Sub(item)
                                       item.Text = "Item 3"
                                       item.Items.Add(Sub(subItem)
                                                              subItem.Text = "Sub Item 3.1"
                                                                          
                                                      End Sub)
                                       item.Items.Add(Sub(subItem)
                                                              subItem.Text = "Sub Item 3.2"
                                                      End Sub)
                               End Sub)
            settings.Items.Add(Sub(item)
                                       item.Text = "Item 4"
                               End Sub)
    End Sub).GetHtml()