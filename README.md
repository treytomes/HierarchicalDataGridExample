# HierarchicalDataGridExample

Hierarchical DataGrids are not easy.  This is the simpliest way I have found to accomplish the task.

The basic premise:  Rather than rebuilding the DataGrid to contain hierarchical sub-collections of children, let each row's viewmodel control the visibility of that row depending on whether the parent of that viewmodel is collapsed.
