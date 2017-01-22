/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGAbsolutePositionTest.html

#include <yoga/Yoga.h>
#include <gtest/gtest.h>

TEST(YogaTest, absolute_layout_width_height_start_top) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetWidth(root, 100);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeStart, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeTop, 10);
  YGNodeStyleSetWidth(root_child0, 10);
  YGNodeStyleSetHeight(root_child0, 10);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_width_height_end_bottom) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetWidth(root, 100);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeEnd, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeBottom, 10);
  YGNodeStyleSetWidth(root_child0, 10);
  YGNodeStyleSetHeight(root_child0, 10);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_start_top_end_bottom) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetWidth(root, 100);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeStart, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeTop, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeEnd, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeBottom, 10);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_width_height_start_top_end_bottom) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetWidth(root, 100);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeStart, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeTop, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeEnd, 10);
  YGNodeStyleSetPosition(root_child0, YGEdgeBottom, 10);
  YGNodeStyleSetWidth(root_child0, 10);
  YGNodeStyleSetHeight(root_child0, 10);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(80, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, do_not_clamp_height_of_absolute_node_to_height_of_its_overflow_hidden_parent) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetFlexDirection(root, YGFlexDirectionRow);
  YGNodeStyleSetOverflow(root, YGOverflowHidden);
  YGNodeStyleSetWidth(root, 50);
  YGNodeStyleSetHeight(root, 50);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeStart, 0);
  YGNodeStyleSetPosition(root_child0, YGEdgeTop, 0);
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child0_child0 = YGNodeNew();
  YGNodeStyleSetWidth(root_child0_child0, 100);
  YGNodeStyleSetHeight(root_child0_child0, 100);
  YGNodeInsertChild(root_child0, root_child0_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root_child0_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root_child0_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(-50, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root_child0_child0));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root_child0_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_within_border) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetMargin(root, YGEdgeLeft, 10);
  YGNodeStyleSetMargin(root, YGEdgeTop, 10);
  YGNodeStyleSetMargin(root, YGEdgeRight, 10);
  YGNodeStyleSetMargin(root, YGEdgeBottom, 10);
  YGNodeStyleSetPadding(root, YGEdgeLeft, 10);
  YGNodeStyleSetPadding(root, YGEdgeTop, 10);
  YGNodeStyleSetPadding(root, YGEdgeRight, 10);
  YGNodeStyleSetPadding(root, YGEdgeBottom, 10);
  YGNodeStyleSetBorder(root, YGEdgeLeft, 10);
  YGNodeStyleSetBorder(root, YGEdgeTop, 10);
  YGNodeStyleSetBorder(root, YGEdgeRight, 10);
  YGNodeStyleSetBorder(root, YGEdgeBottom, 10);
  YGNodeStyleSetWidth(root, 100);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child0, YGEdgeLeft, 0);
  YGNodeStyleSetPosition(root_child0, YGEdgeTop, 0);
  YGNodeStyleSetWidth(root_child0, 50);
  YGNodeStyleSetHeight(root_child0, 50);
  YGNodeInsertChild(root, root_child0, 0);

  const YGNodeRef root_child1 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child1, YGPositionTypeAbsolute);
  YGNodeStyleSetPosition(root_child1, YGEdgeRight, 0);
  YGNodeStyleSetPosition(root_child1, YGEdgeBottom, 0);
  YGNodeStyleSetWidth(root_child1, 50);
  YGNodeStyleSetHeight(root_child1, 50);
  YGNodeInsertChild(root, root_child1, 1);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root_child1));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(10, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root_child0));

  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetLeft(root_child1));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetTop(root_child1));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetWidth(root_child1));
  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetHeight(root_child1));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_align_items_and_justify_content_center) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetJustifyContent(root, YGJustifyCenter);
  YGNodeStyleSetAlignItems(root, YGAlignCenter);
  YGNodeStyleSetFlexGrow(root, 1);
  YGNodeStyleSetWidth(root, 110);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetWidth(root_child0, 60);
  YGNodeStyleSetHeight(root_child0, 40);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(25, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(25, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_justify_content_center) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetJustifyContent(root, YGJustifyCenter);
  YGNodeStyleSetFlexGrow(root, 1);
  YGNodeStyleSetWidth(root, 110);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetWidth(root_child0, 60);
  YGNodeStyleSetHeight(root_child0, 40);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(50, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(30, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}

TEST(YogaTest, absolute_layout_align_items_center) {
  const YGNodeRef root = YGNodeNew();
  YGNodeStyleSetAlignItems(root, YGAlignCenter);
  YGNodeStyleSetFlexGrow(root, 1);
  YGNodeStyleSetWidth(root, 110);
  YGNodeStyleSetHeight(root, 100);

  const YGNodeRef root_child0 = YGNodeNew();
  YGNodeStyleSetPositionType(root_child0, YGPositionTypeAbsolute);
  YGNodeStyleSetWidth(root_child0, 60);
  YGNodeStyleSetHeight(root_child0, 40);
  YGNodeInsertChild(root, root_child0, 0);
  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionLTR);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(25, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeCalculateLayout(root, YGUndefined, YGUndefined, YGDirectionRTL);

  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetLeft(root));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root));
  ASSERT_FLOAT_EQ(110, YGNodeLayoutGetWidth(root));
  ASSERT_FLOAT_EQ(100, YGNodeLayoutGetHeight(root));

  ASSERT_FLOAT_EQ(25, YGNodeLayoutGetLeft(root_child0));
  ASSERT_FLOAT_EQ(0, YGNodeLayoutGetTop(root_child0));
  ASSERT_FLOAT_EQ(60, YGNodeLayoutGetWidth(root_child0));
  ASSERT_FLOAT_EQ(40, YGNodeLayoutGetHeight(root_child0));

  YGNodeFreeRecursive(root);
}
