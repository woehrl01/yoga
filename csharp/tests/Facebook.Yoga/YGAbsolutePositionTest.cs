/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGAbsolutePositionTest.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAbsolutePositionTest
    {
        [Test]
        public void Test_absolute_layout_width_height_start_top()
        {
            YogaNode root = new YogaNode();
            root.Width = 100.Px();
            root.Height = 100.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10.Px());
            root_child0.SetPosition(YogaEdge.Top, 10.Px());
            root_child0.Width = 10.Px();
            root_child0.Height = 10.Px();
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100.Px();
            root.Height = 100.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.End, 10.Px());
            root_child0.SetPosition(YogaEdge.Bottom, 10.Px());
            root_child0.Width = 10.Px();
            root_child0.Height = 10.Px();
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(80f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_start_top_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100.Px();
            root.Height = 100.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10.Px());
            root_child0.SetPosition(YogaEdge.Top, 10.Px());
            root_child0.SetPosition(YogaEdge.End, 10.Px());
            root_child0.SetPosition(YogaEdge.Bottom, 10.Px());
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(80f, root_child0.LayoutWidth);
            Assert.AreEqual(80f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_width_height_start_top_end_bottom()
        {
            YogaNode root = new YogaNode();
            root.Width = 100.Px();
            root.Height = 100.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 10.Px());
            root_child0.SetPosition(YogaEdge.Top, 10.Px());
            root_child0.SetPosition(YogaEdge.End, 10.Px());
            root_child0.SetPosition(YogaEdge.Bottom, 10.Px());
            root_child0.Width = 10.Px();
            root_child0.Height = 10.Px();
            root.Insert(0, root_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(80f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(10f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);
        }

        [Test]
        public void Test_do_not_clamp_height_of_absolute_node_to_height_of_its_overflow_hidden_parent()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Overflow = YogaOverflow.Hidden;
            root.Width = 50.Px();
            root.Height = 50.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Start, 0.Px());
            root_child0.SetPosition(YogaEdge.Top, 0.Px());
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode();
            root_child0_child0.Width = 100.Px();
            root_child0_child0.Height = 100.Px();
            root_child0.Insert(0, root_child0_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(50f, root.LayoutWidth);
            Assert.AreEqual(50f, root.LayoutHeight);

            Assert.AreEqual(-50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(100f, root_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(100f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(100f, root_child0_child0.LayoutHeight);
        }

        [Test]
        public void Test_absolute_layout_within_border()
        {
            YogaNode root = new YogaNode();
            root.SetMargin(YogaEdge.Left, 10.Px());
            root.SetMargin(YogaEdge.Top, 10.Px());
            root.SetMargin(YogaEdge.Right, 10.Px());
            root.SetMargin(YogaEdge.Bottom, 10.Px());
            root.SetPadding(YogaEdge.Left, 10.Px());
            root.SetPadding(YogaEdge.Top, 10.Px());
            root.SetPadding(YogaEdge.Right, 10.Px());
            root.SetPadding(YogaEdge.Bottom, 10.Px());
            root.SetBorder(YogaEdge.Left, 10);
            root.SetBorder(YogaEdge.Top, 10);
            root.SetBorder(YogaEdge.Right, 10);
            root.SetBorder(YogaEdge.Bottom, 10);
            root.Width = 100.Px();
            root.Height = 100.Px();

            YogaNode root_child0 = new YogaNode();
            root_child0.PositionType = YogaPositionType.Absolute;
            root_child0.SetPosition(YogaEdge.Left, 0.Px());
            root_child0.SetPosition(YogaEdge.Top, 0.Px());
            root_child0.Width = 50.Px();
            root_child0.Height = 50.Px();
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.PositionType = YogaPositionType.Absolute;
            root_child1.SetPosition(YogaEdge.Right, 0.Px());
            root_child1.SetPosition(YogaEdge.Bottom, 0.Px());
            root_child1.Width = 50.Px();
            root_child1.Height = 50.Px();
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(10f, root.LayoutX);
            Assert.AreEqual(10f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(10f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);
        }

    }
}
