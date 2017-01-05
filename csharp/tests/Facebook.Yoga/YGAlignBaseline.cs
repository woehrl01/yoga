/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/YGAlignBaseline.html

using System;
using NUnit.Framework;

namespace Facebook.Yoga
{
    [TestFixture]
    public class YGAlignBaseline
    {
        [Test]
        public void Test_align_baseline()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(30f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(30f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_child()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_child_top()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.SetPosition(YogaEdge.Top, 10);
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_child_top2()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.SetPosition(YogaEdge.Top, 5);
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(45f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(45f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_double_nested_child()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child0_child0 = new YogaNode();
            root_child0_child0.Width = 50;
            root_child0_child0.Height = 20;
            root_child0.Insert(0, root_child0_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 15;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(50f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(5f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(15f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child0_child0.LayoutX);
            Assert.AreEqual(0f, root_child0_child0.LayoutY);
            Assert.AreEqual(50f, root_child0_child0.LayoutWidth);
            Assert.AreEqual(20f, root_child0_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(5f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(15f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_column()
        {
            YogaNode root = new YogaNode();
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_child_margin()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.SetMargin(YogaEdge.Left, 5);
            root_child0.SetMargin(YogaEdge.Top, 5);
            root_child0.SetMargin(YogaEdge.Right, 5);
            root_child0.SetMargin(YogaEdge.Bottom, 5);
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.SetMargin(YogaEdge.Left, 1);
            root_child1_child0.SetMargin(YogaEdge.Top, 1);
            root_child1_child0.SetMargin(YogaEdge.Right, 1);
            root_child1_child0.SetMargin(YogaEdge.Bottom, 1);
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(5f, root_child0.LayoutX);
            Assert.AreEqual(5f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(60f, root_child1.LayoutX);
            Assert.AreEqual(44f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(1f, root_child1_child0.LayoutX);
            Assert.AreEqual(1f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(45f, root_child0.LayoutX);
            Assert.AreEqual(5f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(-10f, root_child1.LayoutX);
            Assert.AreEqual(44f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(-1f, root_child1_child0.LayoutX);
            Assert.AreEqual(1f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_multiline()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Wrap = YogaWrap.Wrap;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);

            YogaNode root_child2 = new YogaNode();
            root_child2.Width = 50;
            root_child2.Height = 20;
            root.Insert(2, root_child2);

            YogaNode root_child2_child0 = new YogaNode();
            root_child2_child0.Width = 50;
            root_child2_child0.Height = 10;
            root_child2.Insert(0, root_child2_child0);

            YogaNode root_child3 = new YogaNode();
            root_child3.Width = 50;
            root_child3.Height = 50;
            root.Insert(3, root_child3);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(100f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child3.LayoutX);
            Assert.AreEqual(60f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(50f, root_child3.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child2.LayoutX);
            Assert.AreEqual(100f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(60f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(50f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_self()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.AlignSelf = YogaAlign.Baseline;
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.AlignSelf = YogaAlign.Baseline;
            root_child1.Width = 50;
            root_child1.Height = 20;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_multiline_column()
        {
            YogaNode root = new YogaNode();
            root.AlignItems = YogaAlign.Baseline;
            root.Wrap = YogaWrap.Wrap;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 50;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);

            YogaNode root_child2 = new YogaNode();
            root_child2.Width = 50;
            root_child2.Height = 20;
            root.Insert(2, root_child2);

            YogaNode root_child2_child0 = new YogaNode();
            root_child2_child0.Width = 50;
            root_child2_child0.Height = 10;
            root_child2.Insert(0, root_child2_child0);

            YogaNode root_child3 = new YogaNode();
            root_child3.Width = 50;
            root_child3.Height = 20;
            root.Insert(3, root_child3);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child3.LayoutX);
            Assert.AreEqual(20f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(20f, root_child3.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(50f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(20f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(20f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_align_baseline_multiline_row_and_column()
        {
            YogaNode root = new YogaNode();
            root.FlexDirection = YogaFlexDirection.Row;
            root.AlignItems = YogaAlign.Baseline;
            root.Wrap = YogaWrap.Wrap;
            root.Width = 100;
            root.Height = 100;

            YogaNode root_child0 = new YogaNode();
            root_child0.Width = 50;
            root_child0.Height = 50;
            root.Insert(0, root_child0);

            YogaNode root_child1 = new YogaNode();
            root_child1.Width = 50;
            root_child1.Height = 50;
            root.Insert(1, root_child1);

            YogaNode root_child1_child0 = new YogaNode();
            root_child1_child0.Width = 50;
            root_child1_child0.Height = 10;
            root_child1.Insert(0, root_child1_child0);

            YogaNode root_child2 = new YogaNode();
            root_child2.Width = 50;
            root_child2.Height = 20;
            root.Insert(2, root_child2);

            YogaNode root_child2_child0 = new YogaNode();
            root_child2_child0.Width = 50;
            root_child2_child0.Height = 10;
            root_child2.Insert(0, root_child2_child0);

            YogaNode root_child3 = new YogaNode();
            root_child3.Width = 50;
            root_child3.Height = 20;
            root.Insert(3, root_child3);
            root.StyleDirection = YogaDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(100f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child3.LayoutX);
            Assert.AreEqual(90f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(20f, root_child3.LayoutHeight);

            root.StyleDirection = YogaDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(50f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(50f, root_child0.LayoutWidth);
            Assert.AreEqual(50f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(40f, root_child1.LayoutY);
            Assert.AreEqual(50f, root_child1.LayoutWidth);
            Assert.AreEqual(50f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child1_child0.LayoutX);
            Assert.AreEqual(0f, root_child1_child0.LayoutY);
            Assert.AreEqual(50f, root_child1_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child1_child0.LayoutHeight);

            Assert.AreEqual(50f, root_child2.LayoutX);
            Assert.AreEqual(100f, root_child2.LayoutY);
            Assert.AreEqual(50f, root_child2.LayoutWidth);
            Assert.AreEqual(20f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child2_child0.LayoutX);
            Assert.AreEqual(0f, root_child2_child0.LayoutY);
            Assert.AreEqual(50f, root_child2_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child2_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(90f, root_child3.LayoutY);
            Assert.AreEqual(50f, root_child3.LayoutWidth);
            Assert.AreEqual(20f, root_child3.LayoutHeight);
        }

    }
}
