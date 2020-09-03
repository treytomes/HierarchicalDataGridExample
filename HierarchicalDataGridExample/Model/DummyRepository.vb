Namespace Model

	Public Class DummyRepository

		Public Shared Function GetData() As IEnumerable(Of DummyCategoryModel)
			Return {
				New DummyCategoryModel("Category A", "Blah blah blah", 5, {
					New DummySubCategoryModel("Sub-category 1", "blergl", 3, {
						New DummyRowModel("Row 1", "hello!", 1),
						New DummyRowModel("Row 2", "hello...", 2),
						New DummyRowModel("Row 3", "hello?", 3)
					}),
					New DummySubCategoryModel("Sub-category 2", "blergl 2", 1.5D, {
						New DummyRowModel("Row 4", "asdkljhasd", 4),
						New DummyRowModel("Row 5", "stuff", 5),
						New DummyRowModel("Row 6", "more stuff", 6)
					}),
					New DummySubCategoryModel("Sub-category 3", "blergl 3", 0.75D, {
						New DummyRowModel("Row 7", "A thing", 7),
						New DummyRowModel("Row 8", "B thing", 8),
						New DummyRowModel("Row 9", "C thing", 9)
					})
				}),
				New DummyCategoryModel("Category B", "BLAARGH!", 53, {
					New DummySubCategoryModel("Sub-category 4", "blergl 4", 33, {
						New DummyRowModel("Row 10", "hello!", 11),
						New DummyRowModel("Row 11", "hello...", 12),
						New DummyRowModel("Row 12", "hello?", 13)
					}),
					New DummySubCategoryModel("Sub-category 5", "blergl 5", 17.5D, {
						New DummyRowModel("Row 13", "asdkljhasd", 14),
						New DummyRowModel("Row 14", "stuff", 15),
						New DummyRowModel("Row 15", "more stuff", 16)
					}),
					New DummySubCategoryModel("Sub-category 6", "blergl 6", 90.7D, {
						New DummyRowModel("Row 16", "A thing", 77),
						New DummyRowModel("Row 17", "B thing", 88),
						New DummyRowModel("Row 18", "C thing", 99)
					})
				})
			}
		End Function

	End Class

End Namespace
