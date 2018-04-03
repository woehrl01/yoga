
/**
* Copyright (c) 2014-present, Facebook, Inc.
*
* This source code is licensed under the MIT license found in the
* LICENSE file in the root directory of this source tree.
*/

#pragma once
#include "YGConfig.h"

const std::array<bool, YGExperimentalFeatureCount>
    kYGDefaultExperimentalFeatures = {{false}};

YGConfig::YGConfig(YGLogger logger)
    : useWebDefaults(false),
      experimentalFeatures(kYGDefaultExperimentalFeatures),
      useLegacyStretchBehaviour(false),
      shouldDiffLayoutWithoutLegacyStretchBehaviour(false),
      pointScaleFactor(1.0f), logger(logger), cloneNodeCallback(nullptr),
      context(nullptr) {}

YGConfig::~YGConfig() {}