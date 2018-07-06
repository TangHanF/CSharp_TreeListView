# CSharp_TreeListView
C#winform控件，Listview与Treeview 的结合


# 修订历史
## 2018年07月06日

- 修复原始版本`BeforeLabelEdit` 、`AfterLabelEdit`事件抛出异常问题

- 对`AfterLabelEdit`事件委托参数`TreeListViewBeforeLabelEditEventArgs`进行扩展，增加编辑前（即原始标签）值的属性。示例如下：

  ```c#
  private void treeListView1_AfterLabelEdit(object sender, TreeListViewLabelEditEventArgs e)
  {
  	MessageBox.Show(string.Format("编辑之前的值：{0}，编辑之后的值：{1}",e.LabelOld,e.Label));
  }
  ```

   

